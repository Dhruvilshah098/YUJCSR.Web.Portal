using Newtonsoft.Json;
using System.Net.Http.Headers;
using YUJCSR.Web.Portal.Models;

namespace YUJCSR.Web.CSO.BusinessManager
{
	public class CompanyManager
    {
		private string _baseurl;
		private IConfiguration _configuration;
		public CompanyManager(IConfiguration iConfig)
		{
			_configuration = iConfig;
			_baseurl = _configuration.GetValue<string>("BaseUrl") + "/api/";
		}

		public static string GetApiData(string _baseurl, string methodName)
		{
			using (var client = new HttpClient())
			{

				client.BaseAddress = new Uri(_baseurl);
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				var getData = client.GetAsync(methodName);
				getData.Wait();
				var Res = getData.Result;
				if (Res.IsSuccessStatusCode)
				{
					return Res.Content.ReadAsStringAsync().Result;
				}
			}

			return null;
		}

		public List<CompanyModel> GetCompany()
		{
            List<CompanyModel> lstModel = new List<CompanyModel>();

			try
			{
				string dataResponse = GetApiData(_baseurl, "Company?approval=pending");

				if (!string.IsNullOrEmpty(dataResponse))
				{
                    var dta = JsonConvert.DeserializeObject<CompanyModelResult>(dataResponse);
					lstModel = dta.result;

                }
				return lstModel;

			}
			catch (Exception ex)
			{

				throw;
			}
		}




	}
}