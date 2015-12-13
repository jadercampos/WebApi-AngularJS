using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAngularJS.Domain.Entities;
using WebApiAngularJS.Domain.Interfaces;
using WebApiAngularJS.Repositories.EF;

namespace WebApiAngularJS.UX.WebAPI.Controllers.API
{
    public class EstabelecimentoController : ApiController
    {
        private IEstabelecimentoRepository repositorio;

        public EstabelecimentoController()
        {
            repositorio = new EstabelecimentoRepository();
        }
        [HttpGet]
        public IEnumerable<Estabelecimento> ListarTodos()
        {
            return repositorio.GetList();
        }
        [HttpGet]
        public HttpResponseMessage RetornarPorId(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            return Request.CreateResponse(HttpStatusCode.OK, repositorio.Get(id));
        }
        [HttpPost]
        public HttpResponseMessage Incluir(Estabelecimento estabelecimento)
        {
            if (estabelecimento == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            using (repositorio = new EstabelecimentoRepository())
            {
                estabelecimento.DtInc = DateTime.Now;
                repositorio.Add(estabelecimento);
                repositorio.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPut]
        public HttpResponseMessage Alterar(Estabelecimento estabelecimento)
        {
            if (estabelecimento == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            using (repositorio = new EstabelecimentoRepository())
            {
                estabelecimento.DtInc = DateTime.Now;
                repositorio.Update(estabelecimento);
                repositorio.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpDelete]
        public HttpResponseMessage Excluir(Estabelecimento estabelecimento)
        {
            if (estabelecimento == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            using (repositorio = new EstabelecimentoRepository())
            {
                repositorio.Delete(estabelecimento);
                repositorio.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpDelete]
        public HttpResponseMessage Excluir(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            using (repositorio = new EstabelecimentoRepository())
            {
                repositorio.Delete(id);
                repositorio.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
