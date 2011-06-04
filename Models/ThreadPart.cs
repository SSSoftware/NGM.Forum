﻿using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Data.Conventions;

namespace NGM.Forum.Models {
    public class ThreadPart : ContentPart<ThreadPartRecord> {
        [CascadeAllDeleteOrphan]
        public ForumPart ForumPart {
            get { return this.As<ICommonPart>().Container.As<ForumPart>(); }
            set { this.As<ICommonPart>().Container = value; }
        }

        public int PostCount {
            get { return Record.PostCount; }
            set { Record.PostCount = value; }
        }
    }
}