@echo off
secedit /configure /db C:\Windows\security\new.sdb /cfg %~dp0\securityconfig.cfg /overwrite
pause