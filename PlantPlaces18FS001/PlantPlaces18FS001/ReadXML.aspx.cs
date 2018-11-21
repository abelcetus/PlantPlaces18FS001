﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlantPlaces18FS001
{
    public partial class ReadXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // only execute this logic if the user uploaded a file.
                if (XMLFileUpload.HasFile)
                {
                    // did the user upload an XML File?
                    String allowedExtension = ".xml";
                    String fileName = XMLFileUpload.FileName;
                    String extension = System.IO.Path.GetExtension(fileName).ToLower();

                    if (allowedExtension == extension)
                    {
                        // I have a valid file, I want to save it.
                        String path = Server.MapPath("~/XML/");
                        XMLFileUpload.PostedFile.SaveAs(path + XMLFileUpload.FileName);
                        LblXMLValidation.Text = "File Uploaded";
                    }
                    else
                    {
                        LblXMLValidation.Text = "File type not permitted";
                    }


                }
            }
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            ValidateXML();
        }

        public void ValidateXML()
        {
            // LblXMLValidation.Text = "Button pressed.";
        }
    }
}