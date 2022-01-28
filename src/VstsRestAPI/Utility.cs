﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsRestAPI
{
    public class Utility
    {
        public static string GeterroMessage(string Exception)
        {
            string message = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(Exception))
                {
                    JObject jItems = JObject.Parse(Exception);

                    message = jItems["message"] == null ? "" : jItems["message"].ToString();
                }

                return message;
            }
            catch (Exception)
            {
                return message;
            }
        }
    }

}
