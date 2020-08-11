﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT5
{
    public static class Program

    { public static Splashform splashform;
        public static startform startform;
        public static SelectForm selectform;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;

  
        public static products products;
        /// <summary>;
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashform = new Splashform();
            startform = new startform();
            selectform = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();

            products = new products();
            Application.Run(new Splashform());

        }
    }
}