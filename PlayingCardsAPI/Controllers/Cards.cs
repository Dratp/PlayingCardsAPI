using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayingCardsAPI.Models;

namespace PlayingCardsAPI.Controllers
{
    public class Cards : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NewDeck(int howManyDecks)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response = await client.GetAsync($"/api/deck/new/shuffle/?deck_count=1");
            Deck playingDeck = await response.Content.ReadAsAsync<Deck>();
            return View(playingDeck);
        }

        public async Task<IActionResult> GetHand(string deckid)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response = await client.GetAsync($"/api/deck/{deckid}/draw/?count=6");
            Deck playingDeck = await response.Content.ReadAsAsync<Deck>();
            return View(playingDeck);

        }




    }
}
