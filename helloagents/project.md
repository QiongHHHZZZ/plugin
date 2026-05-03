# 项目技术约定

---

## 技术栈
- **核心:** C#（Dalamud.NET.Sdk 14.0.0，LangVersion=latest）
- **插件框架:** Dalamud / ECommons
- **数据:** Lumina Excel Sheets / JSON 布局文件

---

## 开发约定
- **代码规范:** C# PascalCase，按功能分层组织；允许使用 unsafe/指针访问
- **命名约定:** 类/方法 PascalCase；私有字段常用下划线前缀

---

## 错误与日志
- **策略:** 通过 Log/LogError 统一写入 Svc.Log 与聊天栏
- **日志:** Info/Debug/Error 分级

---

## 测试与流程
- **测试:** 以游戏内手动验证为主，未发现自动化测试
- **提交:** 暂无统一规范（建议后续补充）