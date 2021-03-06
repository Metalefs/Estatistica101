﻿using System;

namespace Exportacao.HTML
{
    public class HTMLElements
    {
        public static string Label(bool final, string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return !final ? $"<label {Properties}>" : "</label>";
        }

        public static string P(bool final, string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return !final ? $"<p {Properties}>" : "</p>";
        }  
        
        public static string Em(bool final, string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return !final ? $"<em {Properties}>" : "</em>";
        }
        public static string Strong(bool final, string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return !final ? $"<strong {Properties}>" : "</strong>";
        }

        public static string Div(bool final, string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return !final ? $"<div {Properties}>" : "</div>";
        }

        public static string Img(string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return $"<img {Properties}>";
        }
        public static string Br(string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return $"</br {Properties}>";
        }
        public static string Hr(string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return $"</hr {Properties}>";
        }

        public static string Input(string Properties)
        {
            return $"<input {Properties} />";
        }

        public static string Form(bool final, string Properties = null)
        {
            Properties = Properties ?? String.Empty;
            return !final ? $"<form {Properties}>" : "</form>";
        }
    }
}
