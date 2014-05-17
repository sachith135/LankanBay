using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class AddressCatogoryDetailsService
    {
        AddressCatogoryDetailsEntry addressCatogoryDetailsEntry = new AddressCatogoryDetailsEntry();

        public DataTable Select(AddressCatogoryDetails addressCatogoryDetails)
        {
            return addressCatogoryDetailsEntry.Select(addressCatogoryDetails);
        }
    }
}