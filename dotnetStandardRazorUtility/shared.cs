using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetStandardRazorUtility
{
    public static class shared
    {
        private static services.RazorViewToStringRenderer _renderer = null;
        public static services.RazorViewToStringRenderer Renderer
        {
            get
            {
                if( _renderer == null)
                {
                    _renderer = services.AspNetCoreInitUtility.GetRenderer();
                }

                return _renderer;
            }
        }


    }
}
