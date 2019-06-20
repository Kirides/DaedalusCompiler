@ECHO OFF
PUSHD ..\src\Parser
REM java -jar ..\..\scripts\antlr-4.7.2-complete.jar -o Output -Dlanguage=CSharp DaedalusLexer.g4 DaedalusParser.g4
java -jar ..\..\scripts\antlr-4.7.2-complete.jar -o Output -Dlanguage=CSharp Daedalus.g4
popd
REM PAUSE