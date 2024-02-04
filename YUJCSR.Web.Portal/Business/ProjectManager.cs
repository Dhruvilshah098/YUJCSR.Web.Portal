using Newtonsoft.Json;
using System.Net.Http.Headers;
using YUJCSR.Web.Portal.Models;

namespace YUJCSR.Web.CSO.BusinessManager
{
	public class ProjectManager
	{
		private string _baseurl;
		private IConfiguration _configuration;
		public ProjectManager(IConfiguration iConfig)
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

		public List<ProjectModel> GetProjects()
		{
			List<ProjectModel> lstModel = new List<ProjectModel>();

			try
			{
				string dataResponse = GetApiData(_baseurl, "Project");

				if (!string.IsNullOrEmpty(dataResponse))
				{
					lstModel = JsonConvert.DeserializeObject<List<ProjectModel>>(dataResponse);
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
