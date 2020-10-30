using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class BooksController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Item> Items { get; set; }
        public List<VolumeInfo> BooksInfo = new List<VolumeInfo>();
      

        const string HARRY_POTTER_BOOKS_URL = "https://www.googleapis.com/books/v1/volumes?q=harry+potter";

        public BooksController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            Items = await GetItems();
            foreach (Item item in Items)
            {
                VolumeInfo book = item.volumeInfo;
                BooksInfo.Add(book);
            }
            return View(Items);
        }

        public async Task<IActionResult> Content(string id)
        {
            VolumeInfo selectedBook = new VolumeInfo();
            Items = await GetItems();
            foreach (Item item in Items)
            {
                if (item.id.Equals(id))
                {
                    selectedBook = item.volumeInfo;
                }
            }
            return View(selectedBook);
        }

        public async Task<IEnumerable<Item>> GetItems()
        {
            IEnumerable<Item> items = new List<Item>();
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri(HARRY_POTTER_BOOKS_URL);
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                QueryItems queryItems = await JsonSerializer.DeserializeAsync<QueryItems>(responseStream);
                items = queryItems.items;
            }
            else
            {
                items = Array.Empty<Item>();
            }
            return items;
        }
    }
}