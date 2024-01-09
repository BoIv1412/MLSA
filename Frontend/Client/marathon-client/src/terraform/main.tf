terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "1.33"  # Specify your desired version here
    }
  }
}

provider "azurerm" {
    client_id           =  var.client_id
    client_secret       =  var.client_secret
    tenant_id           =  var.tenant_id
    subscription_id     =  var.subscription_id
}

resource "azurerm_resource_group" "my_rg" {
    name        =  var.name
    location    =  var.location
}




