#!/bin/bash

mcs src/hello.cs -r:System.Windows.Forms.dll -r:System.Drawing.dll
mono hello.exe
