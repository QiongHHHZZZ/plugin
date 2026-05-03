# 架构设计

## 总体架构
```mermaid
flowchart TD
    UI[Gui/ConfigurationWindow] --> Core[ReMakePlacePlugin]
    Core --> Memory[Memory]
    Core --> Layout[SaveLayoutManager]
    Core --> Data[HousingData]
    Core --> Util[Util]
    Layout --> Data
```

## 技术栈
- **后端:** C#/.NET（Dalamud 插件）
- **前端:** ImGui（Dalamud UI）
- **数据:** Lumina Excel Sheets / JSON 布局文件

## 核心流程
```mermaid
sequenceDiagram
    actor Player as 玩家
    participant UI as GUI
    participant Core as Core
    participant Memory as Memory
    participant Layout as Layout
    Player->>UI: 点击保存/加载
    UI->>Core: 触发操作
    Core->>Memory: 校验模式/访问对象
    Core->>Layout: 导入/导出布局
```

## 重大架构决策
完整的 ADR 存储在各变更的 how.md 中，本章节提供索引。

| adr_id | title | date | status | affected_modules | details |
|--------|-------|------|--------|------------------|---------|
| - | - | - | - | - | - |