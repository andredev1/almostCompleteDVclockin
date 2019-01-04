using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSDetermineOSAndBrowserASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index(string userAgent,  string personalIDnumber, string latitude, string longitude, string osName, string osVersion, string browserName, string browserVersion, string navigatorUserAgent, string navigatorAppVersion, string navigatorPlatform, string navigatorVendor, string dateTime)
        {

            if (string.IsNullOrEmpty(userAgent))
            {
                userAgent = Request.Headers["User-Agent"];
            }

            ViewBag.userAgent = userAgent;

            UserAgent.UserAgent ua = new UserAgent.UserAgent(userAgent);

            var aa = ua.Browser;
            browserName=ua.Browser.Name;
            browserVersion = ua.Browser.Name;
            osVersion = ua.OS.Version;
            osName = ua.OS.Name;

            string ID = personalIDnumber;
            string connectionstring = "Server=tcp:dv-server1234567.database.windows.net,1433;Initial Catalog=DVchoc;Persist Security Info=False;User ID=andredev1234567;Password=Kooler1234567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("Select count(*) from tbl_ClockIn where fld_personalIDnumber='" + ID + "'", connection);
            var count = (int)com.ExecuteScalar();



            com = new SqlCommand("insert into tbl_ClockIn(fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_navigatorUserAgent,fld_navigatorAppVersion,fld_navigatorPlatform,fld_navigatorVendor,fld_latitube,fld_longitude,fld_dateTime) values('', '', '" + personalIDnumber + "', '" + osName + "', '" + osVersion + "', '" + browserName + "', '" + browserVersion + "', '" + navigatorUserAgent + "', '" + navigatorAppVersion + "', '" + navigatorPlatform + "', '" + navigatorVendor + "', '" + latitude + "', '" + longitude + "', '" + System.DateTime.Now + "'); ", connection);
            com.ExecuteScalar();

            

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Maxi', fld_lastName = 'Hobyane' WHERE fld_personalIDnumber = '9508040617089';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Nikkie', fld_lastName = 'Mbhatha' WHERE fld_personalIDnumber = '9501021063084';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Boitumelo', fld_lastName = 'Mufamadi' WHERE fld_personalIDnumber = '9602190461081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Lebogang', fld_lastName = 'Sekgota' WHERE fld_personalIDnumber = '9208290846088';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Noluthando', fld_lastName = 'Mzimkhulu' WHERE fld_personalIDnumber = '9408110298086';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Lethabo', fld_lastName = 'Masogo' WHERE fld_personalIDnumber = '9312020655080';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Evelyn', fld_lastName = 'Nyama' WHERE fld_personalIDnumber = '9207040845085';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Nonokazi ', fld_lastName = 'Zulu' WHERE fld_personalIDnumber = '9008260917087';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Mahlodi Elsie', fld_lastName = 'Monyebodi' WHERE fld_personalIDnumber = '9508040617089';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Fiona', fld_lastName = 'Khati' WHERE fld_personalIDnumber = '9810020198084';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Monica', fld_lastName = 'Dube' WHERE fld_personalIDnumber = '9703240482083';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Audrey', fld_lastName = 'Ngobeni' WHERE fld_personalIDnumber = '9004210492081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Maureen', fld_lastName = 'Komane' WHERE fld_personalIDnumber = '9304190646080';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'pinky', fld_lastName = 'matsitse' WHERE fld_personalIDnumber = '9011050628088';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Madikeledi', fld_lastName = 'Mogotsi' WHERE fld_personalIDnumber = '8903080949081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Liyada', fld_lastName = 'Mukwena' WHERE fld_personalIDnumber = 'FN023166';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Belinda', fld_lastName = 'Ranga' WHERE fld_personalIDnumber = 'DN840476';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Sphosethu ', fld_lastName = 'Sethu' WHERE fld_personalIDnumber = '971102072807';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Tandaza', fld_lastName = 'Benge' WHERE fld_personalIDnumber = '9206130564083';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Daurell', fld_lastName = 'Hufke' WHERE fld_personalIDnumber = '9510080087082';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Deonè', fld_lastName = 'Petersen' WHERE fld_personalIDnumber = '8201140229085';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Bronique ', fld_lastName = 'Solomons ' WHERE fld_personalIDnumber = '9801060151083 ';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Charlotte Kanyiswa ', fld_lastName = 'Mbekwa' WHERE fld_personalIDnumber = '8312221070080';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Michelle', fld_lastName = 'Mpofu' WHERE fld_personalIDnumber = '9712131172083';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'ayanda', fld_lastName = 'cebeni' WHERE fld_personalIDnumber = '8912220865081';", connection);
            com.ExecuteScalar();
            
            return View(ua);
        }
    }
}
