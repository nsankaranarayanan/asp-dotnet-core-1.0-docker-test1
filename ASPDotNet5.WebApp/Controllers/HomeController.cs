using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPDotNet5.WebApp.Models;
using Microsoft.AspNetCore.Http.Features;

namespace ASPDotNet5.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			return (this.View());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

			return (this.View());
		}

		public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

			return (this.View());
		}

		public IActionResult DebugInfo()
		{
			DebugInfoModel model = new DebugInfoModel();

			model.Properties.Add("Request.ContentType", ((Func<string>)(() => { try { return (this.Request.ContentType); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.HasFormContentType", ((Func<string>)(() => { try { return (this.Request.HasFormContentType.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.Host.Host", ((Func<string>)(() => { try { return (this.Request.Host.Host); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.Host.Port", ((Func<string>)(() => { try { return (this.Request.Host.Port.Value.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.IsHttps", ((Func<string>)(() => { try { return (this.Request.IsHttps.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.Method", ((Func<string>)(() => { try { return (this.Request.Method); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.Path", ((Func<string>)(() => { try { return (this.Request.Path.Value); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.PathBase", ((Func<string>)(() => { try { return (this.Request.PathBase.Value); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.Protocol", ((Func<string>)(() => { try { return (this.Request.Protocol); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.QueryString", ((Func<string>)(() => { try { return (this.Request.QueryString.Value); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Request.Scheme", ((Func<string>)(() => { try { return (this.Request.Scheme); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("HttpContext.Connection.LocalIpAddress", ((Func<string>)(() => { try { return (this.HttpContext.Connection.LocalIpAddress.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("HttpContext.Connection.LocalPort", ((Func<string>)(() => { try { return (this.HttpContext.Connection.LocalPort.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("HttpContext.Connection.RemoteIpAddress", ((Func<string>)(() => { try { return (this.HttpContext.Connection.RemoteIpAddress.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("HttpContext.Connection.RemotePort", ((Func<string>)(() => { try { return (this.HttpContext.Connection.RemotePort.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("HttpContext.User.Identity.Name", ((Func<string>)(() => { try { return (this.HttpContext.User.Identity.Name); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("HttpContext.User.Identity.AuthenticationType", ((Func<string>)(() => { try { return (this.HttpContext.User.Identity.AuthenticationType); } catch (Exception ex) { return (ex.Message); } }))());

			try
			{
				foreach (var cookie in this.Request.Cookies)
				{
					model.Properties.Add("Request.Cookies." + cookie.Key, ((Func<string>)(() => { try { return (cookie.Value); } catch (Exception ex) { return (ex.Message); } }))());
				}
			}
			catch( Exception tex )
			{

			}
			try
			{
				foreach (var form in this.Request.Form)
				{
					model.Properties.Add("Request.Form." + form.Key, ((Func<string>)(() => { try { return (form.Value); } catch (Exception ex) { return (ex.Message); } }))());
				}
			}
			catch (Exception tex)
			{

			}
			try
			{
				foreach (var header in this.Request.Headers)
				{
					model.Properties.Add("Request.Headers." + header.Key, ((Func<string>)(() => { try { return (header.Value); } catch (Exception ex) { return (ex.Message); } }))());
				}
			}
			catch (Exception tex)
			{

			}
			try
			{
				foreach (var query in this.Request.Query)
				{
					model.Properties.Add("Request.Query." + query.Key, ((Func<string>)(() => { try { return (query.Value); } catch (Exception ex) { return (ex.Message); } }))());
				}
			}
			catch (Exception tex)
			{

			}
			try
			{
				foreach (var feature in this.HttpContext.Features)
				{
					model.Properties.Add("HttpContext.Features." + feature.Key, ((Func<string>)(() => { try { return (feature.Value.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
				}
			}
			catch (Exception tex)
			{
				
			}

			model.Properties.Add("Environment.MachineName", ((Func<string>)(() => { try { return (Environment.MachineName); } catch (Exception ex) { return (ex.Message); } }))());
			model.Properties.Add("Environment.ProcessorCount", ((Func<string>)(() => { try { return (Environment.ProcessorCount.ToString()); } catch (Exception ex) { return (ex.Message); } }))());
			try
			{
				foreach (var key in Environment.GetEnvironmentVariables().Keys)
				{
					model.Properties.Add("Environment." + key, ((Func<string>)(() => { try { return (Environment.GetEnvironmentVariable(key.ToString())); } catch (Exception ex) { return (ex.Message); } }))());
				}
			}
			catch (Exception tex)
			{

			}

			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());

			//model.Properties.Add("AAAAA", ((Func<string>)(() => { return ("test"); }))());
			//model.Properties.Add("AAAAA", ((Func<string>)(() => { try { return ("AAAAA"); } catch (Exception ex) { return (ex.Message); } }))());

			return (this.View(model));
		}

		public IActionResult Error()
        {
			return (this.View());
		}
	}
}
