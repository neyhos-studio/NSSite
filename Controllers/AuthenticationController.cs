using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
=======
using System.Net.Http;
>>>>>>> 4ad74926a96c949b0f0c325b5f22580c00a36b2e
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSPortal.Models;
using NSPortal.Entities.Authentication;
<<<<<<< HEAD
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
=======
>>>>>>> 4ad74926a96c949b0f0c325b5f22580c00a36b2e

namespace NSPortal.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            //Afficher la page d'inscription
            return View("~/Views/Authentication/Register.cshtml");
        }
<<<<<<< HEAD
        private IConfiguration configuration;

        public AuthenticationController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }

=======
<<<<<<< HEAD

=======
>>>>>>> 9a821875e271942a3052aa0a7aa8931280e8e729
>>>>>>> 4ad74926a96c949b0f0c325b5f22580c00a36b2e
        //Recupération des input et envoie a l API
        public async void SendRegister(string email,
            string password,
            string nickname)
        {
<<<<<<< HEAD
        //creation des objects pour l'envois
            Account registerAccount = new Account(email, password);
            User registerUser = new User(nickname);
            RequestFront RequestFront = new RequestFront(registerAccount, registerUser);
=======
<<<<<<< HEAD


            //Account account = new Account(email, password);
            //User user = new User(nickname);
            //RequestFront requestFront = new RequestFront(account, user);

            RequestFront requestFront = new RequestFront(email, password, nickname);

            var json = JsonConvert.SerializeObject(requestFront);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://92.222.80.11:5000/api/Inscription/Registration";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);


=======
            Account Account = new Account(email, password);
            User User = new User(nickname);
            RequestFront RequestFront = new RequestFront(Account, User);
>>>>>>> 4ad74926a96c949b0f0c325b5f22580c00a36b2e

            //Get apiUrl
            string serverUrl = configuration.GetSection("appUrl").GetSection("apiUrl").Value;
            string apiRegisterUrl = configuration.GetSection("appUrl").GetSection("Register").Value;
            string apiUrl = serverUrl + apiRegisterUrl;

            string ouput = JsonConvert.SerializeObject(RequestFront);
            //envois de l'object apres connexion a l'API
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync(
                     apiUrl,
                     new System.Net.Http.StringContent(ouput, Encoding.UTF8, "application/json"));

                Console.WriteLine(response);
            }
>>>>>>> 9a821875e271942a3052aa0a7aa8931280e8e729
        }

        //Afficher la page Connection
        public IActionResult Connection()
        {
            return View("~/Views/Authentication/Connection.cshtml");
        }
<<<<<<< HEAD
        
        public async void SendConnection(string email, string password)
=======

        public IActionResult Connect(string email, string password)
>>>>>>> 4ad74926a96c949b0f0c325b5f22580c00a36b2e
        {
            //ToDo crypt
            string serverUrl = configuration.GetSection("appUrl").GetSection("apiUrl").Value;
            string apiConnectionUrl = configuration.GetSection("appUrl").GetSection("connection").Value;
            string apiUrl = serverUrl + apiConnectionUrl;

            //creation object d'envois
            Account account = new Account(email, password);
            string ouput = JsonConvert.SerializeObject(account);

            // envois de l'object apres connexion a l'API
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync(
                     apiUrl,
                     new System.Net.Http.StringContent(ouput, Encoding.UTF8, "application/json"));
                Console.WriteLine(response);
            }
            

        }
    }
}

    