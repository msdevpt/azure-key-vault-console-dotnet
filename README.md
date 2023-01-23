# Azure Key Vault

## Tech used:

[.NET Core 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## Overview

This project is how create and read secrets from Azure Key Vault.

## Dependency:
    dotnet add package Azure.Identity
    dotnet add package Azure.Security.KeyVault.Secrets

## Create a resource group
    az group create --name test-rg --location eastus

## Create key vault (**name must be unique**)
    az keyvault create --resource-group test-rg --name test-kv

## Run:
    dotnet run



