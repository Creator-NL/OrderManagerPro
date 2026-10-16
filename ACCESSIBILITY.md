# Accessibility Statement for OrderManagerPro

**Biohazard Corp** is committed to making **OrderManagerPro** practical and accessible for keyboard and assistive-technology users on Windows.

## Supported Environments & Features

- **Platform:** Windows 10 and Windows 11 Desktop (Windows Forms / .NET Framework 4.8).
- **Multi-Language Interface:** Built-in support for English (`EN`), Dutch (`NL`), and German (`DE`) across inquiry forms and main dashboards.
- **Visual & Textual Status Indicators:** Active inquiries use both color coding (Orange for in-progress investigations, Red for Senior Approval) and descriptive cell `ToolTipText` messages so status context is available via hover/assistive hints.
- **Structured Form Validation:** Inquiry creation and investigation forms use explicit two-step validation (`Check` → `Add` / `Ready`) with clear dialog prompts when required fields are missing.

## Known Limitations

- KPI and analytics charts (`System.Windows.Forms.DataVisualization.Charting`) render visual line and pie charts; summary totals and percentages are also displayed as standard readable text labels on the main dashboard.

## Reporting Accessibility Barriers

If you encounter an accessibility barrier in **OrderManagerPro**, please open an issue on GitHub or contact us at **contact@biohazard-corp.nl**.
