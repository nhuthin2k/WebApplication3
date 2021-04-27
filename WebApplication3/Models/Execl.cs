using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
	public class Execl
	{
        private string messager;
		[HttpPost]
		private string UploadExcelFile(HttpPostedFileBase file)
		{
			//dat ten cho file
			string _FileName = "File Name";
			//duong dan luu file
			string _path = Path.Combine(Server.MapPath("Excel"), _FileName);
			//luu file len server
			file.SaveAs(_path);
			return messager = "upload file thanh cong";

		}
		public ActionResult DownloadFile()
		{
			//duong dan chua file muon download
			string path = AppDomain.CurrentDomain.BaseDirectory + "Excel/";
			//chuyen file sang dang byte
			byte[] fileBytes = System.IO.File.ReadAllBytes(path + "FileMau.xlsx");
			//ten file khi download ve
			string fileName = "FileDownLoad.xlsx";
			//tra ve file
			return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
		}

        private ActionResult File(byte[] fileBytes, string octet, string fileName)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadDataFromExcelFile(string filepath)
		{
			string connectionString = "";
			string fileExtention = filepath.Substring(filepath.Length - 4).ToLower();
			if (fileExtention.IndexOf("xlsx") == 0)
			{
				connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + filepath + ";Extended Properties=\"Excel 12.0 Xml;HDR=NO\"";
			}
			else if (fileExtention.IndexOf("xls") == 0)
			{
				connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0";
			}

		}
	}
}