using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using RpgMVC.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace RpgMVC.Models
{
    public class PersonagensController : Controller
    {
        public string uriBase = "Http//localhost:5000/Personagens/";

        [HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            try 
            {
                string uriComplementar = "GetAll";
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response =  await httpClient.GetAsync(uriBase + uriComplementar);
                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                        JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));

                        return View(listaPersonagens);
                }
                else
                    throw new System.Exception(serialized);
            }

                    catch (System.Exception ex)
                    {

                        TempData["MensagemErro"] = ex.Message;
                        return RedirectToAction("Index");
                    }
            }
        }
    }
