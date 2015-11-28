﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMOVStockApp.Models
{
    public class Company
    {
        [JsonProperty("Symbol")]
        public String symbol { get; set; }
        [JsonProperty("Name")]
        public String name { get; set; }

        public Company(String sm,String nm)
        {
            symbol = sm;
            name = nm;
        }
    }
    class StockNameLoad
    {
        public static List<Company> companies = new List<Company>();

        public static Task<List<Company>> getList()
        {
            return Task.Run(() =>
            {
                if (companies.Count < 1)
                {

                    //JObject o1 = JObject.Parse(File.ReadAllText(@"C:\list.json"));
                    companies.Add(new Company("T1","microsoft"));
                    companies.Add(new Company("T2", "google"));
                    companies.Add(new Company("Csaa2", "FEUP"));
                    companies.Add(new Company("Csa21a2", "FEUP"));
                    companies.Add(new Company("Csaawq2", "FEUP"));
                    companies.Add(new Company("Csaeqa2", "FEUP"));
                }
                return companies;
            });
        }

    }

    class YahooFinances
    {
    }
}
/*
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace exampleRPG
{

    public class SummonerBasicInfo
    {

        [JsonProperty("id")]
        public String id { get; set; }

        [JsonProperty("name")]
        public String name { get; set; }

        [JsonProperty("profileIconId")]
        public String profileIconId { get; set; }

        [JsonProperty("summonerLevel")]
        public String summonerLevel { get; set; }
    }

    public class Match
    {
        [JsonProperty("gameMode")]
        public string gameMode { get; set; }

        [JsonProperty("subType")]
        public string subType { get; set; }

        [JsonProperty("fellowPlayers")]
        public List<Player> fellowPlayers { get; set; }
    }

    public class Player
    {
        [JsonProperty("summonerId")]
        public string summonerId { get; set; }

        [JsonProperty("championId")]
        public string championId { get; set; }
    }

    public class RESTCommunication
    {

        public async Task<SummonerBasicInfo> getSummonerBasicInfo(String summoner)
        {
            SummonerBasicInfo sum = new SummonerBasicInfo();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync("https://euw.api.pvp.net/api/lol/euw/v1.4/summoner/by-name/" + summoner + "?api_key=101d9000-e5e0-4aef-b97f-4e455a526e1f"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        JObject root = JObject.Parse(content);
                        JToken jtoken = root.First;
                        String info = ((JProperty)jtoken).Value.ToString();

                        sum = JsonConvert.DeserializeObject<SummonerBasicInfo>(info);
                    }
                }
            }
            return sum;
        }


        public async Task<List<Match>> getSummonerRecentMatchesInfo(string id)
        {

            string content = "test";
            List<Match> recMatches = new List<Match>();
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync("https://euw.api.pvp.net/api/lol/euw/v1.3/game/by-summoner/" + id + "/recent?api_key=101d9000-e5e0-4aef-b97f-4e455a526e1f"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        content = await response.Content.ReadAsStringAsync();
                        JObject root = JObject.Parse(content);
                        JToken jtoken = root.Last;
                        String matches = ((JProperty)jtoken).Value.ToString();
                        recMatches = JsonConvert.DeserializeObject<List<Match>>(matches);
                    }
                }
            }
            return recMatches;
        }
    }
}
*/
