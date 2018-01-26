using System;
using System.Collections.Generic;
using System.Text;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace ProjectPanda.Services
{
     public class QrCodeScanner
    {
        async public void ReadQrCode()
        {

            var scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) => {

                scanPage.IsScanning = false;


                

            };

        }


    }
}
