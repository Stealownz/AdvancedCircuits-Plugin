﻿// This file is provided unter the terms of the 
// Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/3.0/.
// 
// Written by CoderCow

using System;

namespace Terraria.Plugins.Common.AdvancedCircuits {
  public enum CircuitWarnReason {
    None,
    SignalesTooManyPumps,
    SignalesTooManyDartTraps,
    SignalesTooManyStatues,
    InsufficientPermissionToSignalComponent,
    BlockActivatorChangedTooManyBlocks
  }
}