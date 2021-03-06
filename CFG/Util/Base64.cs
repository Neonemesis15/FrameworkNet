﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Lucky.CFG.Util
{
    public class Base64
    {
        public static byte[] DecodeFrom64(String encodedData)
        {

            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);

            return encodedDataAsBytes;

        }

        /// <summary>
        /// Returns the base64 encoded string representation of the given image.
        /// </summary>
        /// <param name="image">A System.Drawing.Image to encode as a string.</param>
        public static string ImageToBase64String(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        /// <summary>
        /// Creates a new image from the given base64 encoded string.
        /// </summary>
        /// <param name="base64String">The encoded image data as a string.</param>
        public static Image ImageFromBase64String(string base64String)
        {
            using (MemoryStream stream = new MemoryStream(
                Convert.FromBase64String(base64String)))
            using (Image sourceImage = Image.FromStream(stream))
            {
                return new Bitmap(sourceImage);
            }
        }


    }
}
