﻿#light

namespace Vim
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Editor

type IVimHost =
    /// Update a single line status message
    abstract UpdateStatus : string -> unit
    /// Update a much longer piece of status information.  Typically called for
    /// the output of a command which is specifically designed for output vs.
    /// function result information
    abstract UpdateLongStatus : string seq -> unit
    abstract Beep : unit -> unit
    abstract OpenFile : string -> unit
    abstract Undo : ITextBuffer -> count:int -> unit
    abstract Redo : ITextBuffer -> count:int -> unit
    abstract GoToDefinition : unit -> bool
    abstract GetName : ITextBuffer -> string
    abstract NavigateTo : point : VirtualSnapshotPoint -> bool

