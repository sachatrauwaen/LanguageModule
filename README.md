# LanguageModule
Language Module for Abp

[![.NET](https://github.com/sachatrauwaen/LanguageModule/actions/workflows/main.yml/badge.svg)](https://github.com/sachatrauwaen/LanguageModule/actions/workflows/main.yml)

## Features

- **Create, Delete, and Edit Languages**: Administrators can easily add new languages, remove unnecessary ones, and update details of existing languages to reflect any changes.
- **Set a Default Language**: This feature allows setting a particular language as the default for the application, enhancing the user experience by providing a primary language selection.
- **Caching**: To ensure high performance and reduce database load, language settings are cached. The cache is smartly invalidated and refreshed on any update, deletion, or creation of a language, ensuring data consistency and quick access.
- **Localization**: The module is designed to support localization, enabling the application to offer a tailored user experience in multiple languages(English, French and Dutch). This is crucial for global applications aiming to serve a diverse user base.
- **Permissions**: Access to different functionalities within the module is controlled through permissions. This allows for granular control over who can create, edit, delete, or set the default language, ensuring that only authorized users can make changes to the language settings.
- **Multi-Tenancy Support**: The module is built to support multi-tenancy, allowing different tenants to manage their language settings independently. This feature is essential for SaaS applications looking to provide personalized experiences to each tenant.
