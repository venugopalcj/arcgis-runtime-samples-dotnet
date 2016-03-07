﻿//Copyright 2015 Esri.
//
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at
//
//http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.
using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Mapping;
using System;

namespace ArcGISRuntime.Windows.Samples.ArcGISTiledLayerUrl
{
    public partial class ArcGISTiledLayerUrl
    {
        public ArcGISTiledLayerUrl()
        {
            InitializeComponent();

            // TODO : Move this to XAML
            var myMap = new Map();

            var baseLayer = new ArcGISTiledLayer(
                new Uri("http://services.arcgisonline.com/arcgis/rest/services/World_Street_Map/MapServer"));
            myMap.Basemap.BaseLayers.Add(baseLayer);
            MyMapView.Map = myMap;
        }
    }
}