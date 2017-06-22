using System;
using System.Net;
using System.Web.Http;
using LegacyProject.BookSigning;

namespace LegacyProject.DataLayer
{
    public class AppearanceController: ApiController
    {
        private readonly IAppearanceRepository _repository;

        public AppearanceController(IAppearanceRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IHttpActionResult UpdateAppearance(int id, [FromBody] Appearance appearance)
        {
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }

            try
            {
                _repository.UpdateAppearance(appearance);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
            return StatusCode(HttpStatusCode.Accepted);
        }
    }
}