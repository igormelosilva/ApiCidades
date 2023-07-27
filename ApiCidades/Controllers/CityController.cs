using System;
using ApiCidades.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCidades.Controllers
{
    public class CityController : Controller
    {
        [HttpGet]
        [Route("GetCityName")]
        public JsonResult GetCityName(int id)
        {
            try
            {
                if (id == 1)
                {
                    return new JsonResult("Caxias do Sul");
                }
                else if (id == 2)
                {
                    return new JsonResult("São Paulo");
                }
                else if (id == 3)
                {
                    return new JsonResult("Rio de Janeiro");
                }
                else
                    return new JsonResult("Id não encontrado");
            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCity")]
        public JsonResult GetCity(int id)
        {
            City city = new City();
            try
            {
                if (id == 1)
                {
                    city.codigo = 1;
                    city.nome = "Caxias";
                    city.regiao = "Sul";
                    city.estado = "RS";
                    city.habitantes = 600000;
                    city.data = Convert.ToDateTime("20/06/1890");
                }
                else if (id == 2)
                {
                    city.codigo = 2;
                    city.nome = "São Paulo";
                    city.regiao = "Sudeste";
                    city.estado = "SP";
                    city.habitantes = 12033000;
                    city.data = Convert.ToDateTime("25/01/1554");
                }
                else if (id == 3)
                {
                    city.codigo = 3;
                    city.nome = "Rio de Janeiro";
                    city.regiao = "Sul";
                    city.estado = "RS";
                    city.habitantes = 6748000;
                    city.data = Convert.ToDateTime("01/03/1565");
                }

            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            return new JsonResult(city);
        }
        [HttpGet]
        [Route("GetAllCity")]
        public JsonResult GetAllCity()
        {
            List<City> listCity = new List<City>();
            try
            {
                City city = new City();
                city.codigo = 1;
                city.nome = "Caxias";
                city.regiao = "Sul";
                city.estado = "RS";
                city.habitantes = 600000;
                city.data = Convert.ToDateTime("20/06/1890");
                listCity.Add(city);

                city = new City();
                city.codigo = 2;
                city.nome = "São Paulo";
                city.regiao = "Sudeste";
                city.estado = "SP";
                city.habitantes = 12033000;
                city.data = Convert.ToDateTime("25/01/1554");
                listCity.Add(city);

                city = new City();
                city.codigo = 3;
                city.nome = "Rio de Janeiro";
                city.regiao = "Sudeste";
                city.estado = "RS";
                city.habitantes = 6748000;
                city.data = Convert.ToDateTime("01/03/1565");
                listCity.Add(city);
            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            return new JsonResult(listCity);
        }
        

        
    }
}
