variable "client_id" {
    description     = " Service principle ID used for deployment"
    type	        = string
}

variable "client_secret" {
    description     = "The client secret"
    type	        = string
}

variable "tenant_id" {
    description     = "The tenant id"
    type	        = string
}

variable "subscription_id" {
    description     = "The subs id"
    type	        = string
}

variable "name" {
    description    ="Name of the resource group"
    type	       = string
}

variable "location" {
    description    ="Location"
    type	       = string
}