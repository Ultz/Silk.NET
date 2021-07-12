# Licensed to the .NET Foundation under one or more agreements.
# The .NET Foundation licenses this file to you under the MIT license.

cmake_minimum_required(VERSION 3.16)
project(SumC C)

set(CMAKE_C_STANDARD 99)

include_directories (include ${PROJECT_BINARY_DIR})

file (GLOB SOURCES "*.c")

include (GenerateExportHeader)
add_library(SumC SHARED ${SOURCES})
GENERATE_EXPORT_HEADER (SumC
        BASE_NAME SumC
        EXPORT_MACRO_NAME SumC_EXPORT
        EXPORT_FILE_NAME SumC_Export.h
        STATIC_DEFINE SumC_BUILT_AS_STATIC
        )