﻿/* 
	BreadPlayer. A music player made for Windows 10 store.
    Copyright (C) 2016  theweavrs (Abdullah Atta)

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using BreadPlayer;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace SplitViewMenu
{
	public class SimpleNavMenuItem :  ViewModelBase, INavigationMenuItem
    {
        public SimpleNavMenuItem()
        {

        }
        string label;
        public string Label { get { return label; } set { Set(ref label, value); } }
        public Symbol Symbol { get; set; }
        public char SymbolAsChar => (char) Symbol;
        public string FontGlyph { get; set; }
        object args;
        public object Arguments { get { return args; } set { Set(ref args, value); } }
    
        List<Shortcut> shortcuts = new List<Shortcut>() { new Shortcut() { SymbolAsChar = "\xE00E", ShortcutCommand = new DelegateCommand(() => BreadPlayer.Services.NavigationService.Instance.Frame.GoBack()) }, new Shortcut() { SymbolAsChar = "\xE110", ShortcutCommand = new DelegateCommand(() => BreadPlayer.Services.NavigationService.Instance.Frame.GoForward()) }, new Shortcut() { SymbolAsChar = "\xE149" }, new Shortcut { SymbolAsChar = "\xE80F" }, new Shortcut() { SymbolAsChar = "\xE094" } };
        public List<Shortcut> Shortcuts
        {
            get { return shortcuts; }
            set
            {
                Set(ref shortcuts, value);
            }
        }
        public Type DestinationPage { get; set; }

        void Select(object param) { }

    }
}