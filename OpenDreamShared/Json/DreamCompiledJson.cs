﻿using System.Collections.Generic;

namespace OpenDreamShared.Json {
    class DreamCompiledJson {
        public List<string> Strings { get; set; }
        public ProcDefinitionJson GlobalInitProc { get; set; }
        public List<string> Maps { get; set; }
        public string Interface { get; set; }
        public DreamObjectJson RootObject { get; set; }
    }
}
