# AnalyzerRunner
Tool that can automate running Roslyn analzers and code fixers on an msbuild project. It takes the analyzers that are enabled in your solution/project and runs them. 

## Usage
     AnalyzerRunner [options] <Solution>
       Options:
           /all       Run all analyzers, including ones that are disabled by default
           /stats     Display statistics of the solution
           /codefixes Test single code fixes
           /fixall    Test fix all providers
           /id:<id>   Enable analyzer with diagnostic ID <id> (when this is specified, only this analyzer is enabled)
           /apply     Write code fix changes back to disk
           /force     Force an analyzer to be enabled, regardless of the configured rule set(s) for the solution
           /editperf[:<match>]     Test the incremental performance of analyzers to simulate the behavior of editing files. If <match> is specified, only files matching this regular expression are evaluated for editor performance.
           /edititer:<iterations>  Specifies the number of iterations to use for testing documents with /editperf. When this is not specified, the default value is 10.
    

## Note
This tool was largely adapted from https://github.com/DotNetAnalyzers/StyleCopAnalyzers/tree/master/StyleCop.Analyzers/StyleCopTester.
The goal is to enventually move this into either the https://github.com/dotnet/roslyn-analyzers repo or back into https://github.com/DotnetAnalyzers as a standalone tool.

Many of the code fixers for some of the issues aren't implemented. The codefixers live in the https://github.com/dotnet/roslyn-analyzers repo.
