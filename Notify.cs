﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Pos_PointOfSales
{
    class Notify
    {
       
        public static void SendRecepit(Recepit recepit)
        {
            Configuration conf = new Configuration();
            conf.Username = Global.settings.SMSProviderUSer;//"YOUR_MESSENTE_API_USERNAME"
            conf.Password = Global.settings.SMSProviderPass;//"YOUR_MESSENTE_API_PASSWORD"
            var apiInstance = new OmnimessageApi(conf);

            string msg = "";

            msg = $"DOCUMENTO COMMERCIALE \n di vedità o prestazione \n\n Descrizione------Prezzo IVA\n";
            decimal value = 0;
            decimal Taxvalue = 0;
            int qta = 0;
            foreach (RecepitRow row in recepit.row)
            {
                msg = msg + $"{row.article.description}x{row.qta.ToString()}--{row.valuetotax.ToString()}-{row.article.salesTax.ToString()} \n";
                value += row.valuetotax;
                Taxvalue += (row.valuetotax - row.value);
                qta += row.qta;
            }

            msg = msg + $"\n Numero Articoli --- {qta}\n TOTALE COMPLESSIVO -- {value}\n di cui IVA ---- {Taxvalue}\n\n --Secure Key-- \n\n {recepit.SecureKey}";

            var sms = new SMS(
                text: msg
            );
            List<object> messages = new List<object>();
            messages.Add(sms);

            var omnimessage = new Omnimessage(
                to: $"+39{recepit.costumer.phoneNumber}",
                messages: messages
            );

            try
            {
                var result = apiInstance.SendOmnimessage(omnimessage);
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling SendOmnimessage: " + e.Message);

            }
        }
    }
}
