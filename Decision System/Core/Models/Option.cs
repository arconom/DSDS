﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Option : BaseModel, IAggregateRoot
    {
        private string name;
        private string description;
        private List<int> attachmentIds;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public List<int> AttachmentIds { get => attachmentIds; set => attachmentIds = value; }
        public virtual List<Attachment> Attachments { get; }

        public Option()
        {

        }
        public Option(string name, string description, List<int> attachmentIds)
        {
            Name = name;
            Description = description;
            AttachmentIds = attachmentIds;
        }

    }
}
