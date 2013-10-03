﻿namespace Glimpse.WebForms.Model
{
    public class ControlTreeItem
    {
        public string ParentControlId { get; set; }

        public string ControlId { get; set; }

        public string Type { get; set; }

        public int? RenderSize { get; set; }

        public int? ViewstateSize { get; set; }

        public int? ControlstateSize { get; set; }

        public int Level { get; set; }
    }
}