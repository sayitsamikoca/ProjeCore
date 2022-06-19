using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjeCore.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(Admin admin)
        {
            // Identity kullanacağımız için devreye async ifadeler girer.

            var bilgiler = context.Admins.FirstOrDefault(x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);

            if (bilgiler != null) {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name , admin.Kullanici)
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal); 
                return RedirectToAction("Index", "Personels");




                /* Notes!
                 * bilgilerden null gelmezse burası çalışır aksi durumda View'i return eder.
                 * İnputlara girmiş olduğum kullanici degeriyle sifre değeri eşleşirse null dönmeyecek.
                 * claims: talepler
                 * ClaimsPricipal: Birden çok talep tabanlı kimliği destekleyen app.
                 * async bir ifadeyi kullanabilmek için önüne 'await' koymak gerekli.
                 */
            }
            return View();

        }
    }
}
