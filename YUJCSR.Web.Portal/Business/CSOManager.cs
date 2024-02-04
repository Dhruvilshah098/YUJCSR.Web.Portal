using Newtonsoft.Json;
using System.Net.Http.Headers;
using YUJCSR.Web.Portal.Models;

namespace YUJCSR.Web.CSO.BusinessManager
{
	public class CSOManager
	{
		private string _baseurl;
		private IConfiguration _configuration;
		public CSOManager(IConfiguration iConfig)
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

		public List<CSOModel> GetCSO()
		{
			List<CSOModel> lstModel = new List<CSOModel>();

			try
			{
				string dataResponse = GetApiData(_baseurl, "CSO?approval=pending");

				if (!string.IsNullOrEmpty(dataResponse))
				{
					var data = JsonConvert.DeserializeObject<CSOResultModel>(dataResponse);
					lstModel = data.result;

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