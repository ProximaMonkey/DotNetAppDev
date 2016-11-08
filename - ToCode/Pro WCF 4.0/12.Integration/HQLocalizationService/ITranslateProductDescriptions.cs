﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.ServiceModel.Web;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITranslateProductDescriptions" in both code and config file together.
[ServiceContract]
public interface ITranslateProductDescriptions
{
    
    [OperationContract]
    [WebGet(UriTemplate = @"/{languageCode}/{productID}")]
    string GetProductDescription(string productID, string languageCode);
}