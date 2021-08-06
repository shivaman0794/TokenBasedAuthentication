using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DSOFile;

namespace TokenBasedAuthentication.Controllers
{
    public class SetPlantNameController : ApiController
    {
        [HttpGet]
        public static void GetPlantNameOnPIDFile()
        {
            string strDwgPIDFilePath = @"\\in-w16sql17ser\Data\Ciphers\CompareSite\ComparePlant\Area1\Unit1\5.pid";
            string strDPName = "p7";

            //CustomDocProps docProps = new CustomDocProps();
            OleDocumentProperties docProps = new OleDocumentProperties();



            //strDwgPath = GetOptionSetting(m_DwgMgrApp.TargetDataPile, "PlantSetting", "2000")
            //docProps.OpenDocument(strDwgPIDFilePath, AccessConstant.igReadWrite);

            docProps.Open(strDwgPIDFilePath, false);

            var plantNameCustomProperty = docProps.CustomProperties.OfType<CustomProperty>().SingleOrDefault(property => property.Name.Equals("_PlantName"));

            if (Convert.ToString(plantNameCustomProperty.get_Value()) != strDPName)
            {
                plantNameCustomProperty.set_Value(strDPName);
                //docProps["_PlantName"].Value = strDPName;
            }

            docProps.Close(true);
            docProps = null;
            return;
        }
    }
}
