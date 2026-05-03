# ReMakePlace Plugin

> 本文件包含项目级别的核心信息。详细的模块文档见 `modules/` 目录。

---

## 1. 项目概述

### 目标与背景
为 FFXIV Dalamud 环境提供房屋家具布局的保存、加载、匹配与染色辅助。

### 范围
- **范围内:** 室内/室外/岛屿布局导入导出、匹配与应用、染色辅助
- **范围外:** 物品库存/仓库管理、对外网络 API、CN 服兼容保证

### 干系人
- **负责人:** 项目维护者

---

## 2. 模块索引

| 模块名称 | 职责 | 状态 | 文档 |
|---------|------|------|------|
| core | 插件生命周期与核心流程 | ✅稳定 | [core](modules/core.md) |
| gui | ImGui 配置窗口与交互 | ✅稳定 | [gui](modules/gui.md) |
| memory | 游戏内存访问与模式判断 | ✅稳定 | [memory](modules/memory.md) |
| layout | 布局导入导出与转换 | ✅稳定 | [layout](modules/layout.md) |
| data | Housing 数据缓存 | ✅稳定 | [data](modules/data.md) |
| objects | 数据结构与内存结构 | ✅稳定 | [objects](modules/objects.md) |
| util | 通用工具与 Hook | ✅稳定 | [util](modules/util.md) |

---

## 3. 快速链接
- [技术约定](../project.md)
- [架构设计](arch.md)
- [API 手册](api.md)
- [数据模型](data.md)
- [变更历史](../history/index.md)