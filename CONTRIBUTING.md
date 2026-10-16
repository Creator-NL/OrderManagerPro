# Contributing to OrderManagerPro

Thank you for your interest in contributing to **OrderManagerPro**! Whether you are fixing a bug, improving database queries, enhancing analytics dashboards, or expanding multi-language translations, your help is welcome.

---

## Core Principles

1. **Zero Telemetry & Local-First:** OrderManagerPro runs 100% locally against a SQL Server / LocalDB database without external cloud dependencies, tracking, or telemetry.
2. **Data Integrity & Auditability:** Warehouse inquiry workflows depend on accurate state transitions (`Active` → `Ready` → `Finished`) and clear audit trails (`NameCreator`, `InvestigatedBy`, timestamps).
3. **Multi-Language Support:** UI additions should maintain translations across English (`EN`), Dutch (`NL`), and German (`DE`).

---

## Development Setup

1. **Prerequisites:**
   - Windows 10 or Windows 11
   - [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** and **Data storage and processing** (SQL Server Express LocalDB) workloads
   - .NET Framework 4.8 Developer Pack
2. **Clone & Build:**
   ```powershell
   git clone https://github.com/Creator-NL/OrderManagerPro.git
   cd OrderManagerPro
   ```
3. Initialize the LocalDB database using [`database/schema.sql`](database/schema.sql).
4. Open `OrderManagerPro.sln` in Visual Studio 2022 and press `F5` or click **Build > Build Solution**.

---

## Submitting Changes

1. Fork the repository and create a feature branch from `main` (e.g., `feature/parameterized-queries` or `fix/chart-dpi`).
2. Test your changes across Inbound, Stock Control, and Admin workflows.
3. Ensure no `bin/`, `obj/`, `.vs/`, `.mdf`, or `.pfx` files are staged.
4. Open a Pull Request with a clear description of what changed and why.
