﻿#region License

/*
 * Copyright © 2002-2005 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;
using System.Collections.Generic;
using System.Text;
using Spring.Core.IO;

namespace Spring.Context.Support
{
    public abstract class AbstractXmlApplicationContextArgs
    {

        public virtual bool CaseSensitive { get; set; }

        public virtual string[] ConfigurationLocations { get; set; }

        public virtual IResource[] ConfigurationResources { get; set; }

        public virtual string Name { get; set; }

        public virtual IApplicationContext ParentContext { get; set; }

        public virtual bool Refresh { get; set; }

        /// <summary>
        /// Initializes a new instance of the AbstractXmlApplicationContextArgs class.
        /// </summary>
        public AbstractXmlApplicationContextArgs()
        {
            ConfigurationLocations = new string[0];
            ConfigurationResources = new IResource[0];
        }

    }
}
