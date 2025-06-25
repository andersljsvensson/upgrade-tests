# VB.NET Migration Tool Testing Instructions

Roklem is an automated migration tool that assists in converting VB.NET Framework projects to VB.NET Core using LLMs. The tool outputs a directory containing partlyt migrated code with commented changes in all migrated files.. This study aims to evaluate the usability and effectiveness of Roklem’s migration output.

## Description
You will complete two tasks:
A warm-up task to get familiar with Roklem’s migration output. (maximum ~20 minutes of time)
A main task using a different project.

In both tasks, your goal is to produce a compilable and runnable version of the application based on Roklem’s partially migrated output.

## Table of Contents
- [Projects Overview](#projects-overview)
- [Setup & Installation](#setup--installation)
- [Goals of the test](#goals-of-the-test)


## Projects Overview
You will work with two VB.NET projects, both of which have been partially migrated using Roklem to .net 6.0:
1. **WindowsFormsHelloWorld** – A basic WinForms application.
2. **Template** – An application used as a UI template.

## Setup & Installation
Clone this repo and you find the two partly migrated projects in the folder /roklem-output
**WindowsFormsHelloWorld**
**Template**
Ensure you have the required .NET SDKs installed for both .NET Framework and .NET Core. Visual Studio 2022 will prompt you to install these if they are not already installed.


## Goals of the test
The goal of the test is to get the provided projects to build and run within the 2 hours given. You are allowed to use the integrated GitHub Copilot however, no chat agents such as ChatGPT or Claude are allowed.

For the test you are not allowed to migrate to any other version of .net core than the one proposed by Roklem.
