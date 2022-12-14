using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using W3Class.Models;
using Newtonsoft.Json;

namespace W3Class.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        // test string https://localhost:7103/home/CsvCalc?csv=2,4,9,45,12,789,23,6

        public IActionResult CsvCalc(string csv)
        {
            Response.ContentType = "text/html";
            string[] values = csv.Split(',');
            double total = 0;
            double average = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total = total + double.Parse(values[i]);
            }
            average = total / values.Length;
            string output = "<h2>The total is: " + total + "</h2>" + "<h3>The average is: " + average + "</h3>";
            return Content(output);
        }
        // test string https://localhost:7103/home/UpperCase?json=[%22technology%22,%22is%22,%22best%22,%22when%22,%22it%22,%22brings%22,%22people%22,%22together%22]
        public IActionResult UpperCase(string json)
        {
            Response.ContentType = "text/html";
            string[] words = JsonConvert.DeserializeObject<string[]>(json);

            List<string> capitalisedWords= new List<string>();
            List<string> capitalisedLetters = new List<string>();

            for (int i=0; i<words.Length; i++)
            {
                string capitalised = words[i].ToUpper();
                capitalisedWords.Add(capitalised);
                string capitalLetters = char.ToUpper(words[i][0])+ words[i].Substring(1);
                capitalisedLetters.Add(capitalLetters);


            }
            string output = "<h2 style=color:green >Capitalised sentence is " + string.Join(" ", capitalisedWords) +"</h2></br>"+
                "<h3 style=color:blue>Capitalised first letter is : " + string.Join(" ", capitalisedLetters)+"</h3>";
            return Content(output);
        }

        // test string https://localhost:7103/home/JsonCalc?json=[2,4,9,45,12,789,23,6]
        public IActionResult JsonCalc(string json)
        {
            Response.ContentType = "text/html";
            double[] values = JsonConvert.DeserializeObject<double[]>(json);
            double minimum=Double.MaxValue;
            double maximum=Double.MinValue;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i]< minimum)
                {
                    minimum = values[i];
                }
                if(values[i]>maximum)
                {
                    maximum = values[i];
                }
            }
            string output = "<h1> the maximum is :" + maximum + "</h1><h1> The minimum is " + minimum + "</h1>";



                return Content(output);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}