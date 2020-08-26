﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZagrosRealState.Common.PublicClasses
{
    public class BootstrapModel
    {
        public string ID { get; set; }
        public string AreaLabeledId { get; set; }
        public ModalSize Size { get; set; }
        public string Message { get; set; }
        public string ModalSizeClass
        {
            get
            {
                switch (this.Size)
                {
                    case ModalSize.Small:
                        return "modal-sm";
                    case ModalSize.Large:
                        return "modal-lg";
                    case ModalSize.Medium:
                        return "modal-md";
                    default:
                        return "";
                }
            }
        }
    }
}
