using ApiCidades.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCidades.Controllers
{
    public class UfController : Controller
    {
        [HttpGet]
        [Route("GetUfName")]
        public JsonResult GetUfName(int id)
        {
            try
            {
                if (id == 1)
                {
                    return new JsonResult("Rio Grande do Sul");
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
        [Route("GetUf")]
        public JsonResult GetUf(string name)
        {
            Uf uf = new Uf();
            try
            {
                if (name == "Rio Grande do Sul")
                {
                    uf.codigo = 1;
                    uf.nome = "Rio Grande do Sul";
                    uf.capital = "Porto Alegre";
                    uf.regiao = "Sul";
                    uf.populacao = 600000;
                }
                else if (name == "São Paulo")
                {
                    uf.codigo = 2;
                    uf.nome = "São Paulo";
                    uf.capital = "São Paulo";
                    uf.regiao = "Sudeste";
                    uf.populacao = 600000;
                }
                else if (name == "Rio de Janeiro")
                {
                    uf.codigo = 3;
                    uf.nome = "Rio de Janeiro";
                    uf.capital = "Rio de Janeiro";
                    uf.regiao = "Sudeste";
                    uf.populacao = 600000;
                }

            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            return new JsonResult(uf);
        }
        [HttpGet]
        [Route("GetAllUf")]
        public JsonResult GetAllUf()
        {
            List<Uf> listUf = new List<Uf>();
            try
            {
                Uf uf = new Uf();
                uf.codigo = 1;
                uf.nome = "Rio Grande do Sul";
                uf.capital = "Porto Alegre";
                uf.regiao = "Sul";
                uf.populacao = 600000;
                listUf.Add(uf);

                uf.codigo = 2;
                uf.nome = "São Paulo";
                uf.capital = "São Paulo";
                uf.regiao = "Sudeste";
                uf.populacao = 700000;
                listUf.Add(uf);

                uf.codigo = 3;
                uf.nome = "Rio de Janeiro";
                uf.capital = "Rio de Janeiro";
                uf.regiao = "Sudeste";
                uf.populacao = 800000;
                listUf.Add(uf);
            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            return new JsonResult(listUf);
        }
    }
}
