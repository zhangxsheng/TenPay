﻿using TenPay.lib;

namespace TenPay
{
    /**
    * 	配置账号信息
    */
    public class WxPayConfig
    {

        private static volatile IConfig config;
        private static object syncRoot = new object();

        public static IConfig GetConfig(){
            if(config==null){
                lock(syncRoot){
                    if (config == null)
                        config = new  DemoConfig();
                }
            }
            return config;
        } 


       


    }
}