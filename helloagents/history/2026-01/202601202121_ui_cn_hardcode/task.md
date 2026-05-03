# 任务清单: UI 文案硬编码汉化

目录: `helloagents/plan/202601202121_ui_cn_hardcode/`

---

## 1. GUI 文案替换
- [√] 1.1 在 `ReMakePlacePlugin/Gui/ConfigurationWindow.cs` 中替换按钮、提示、表头、分区标题为中文，保留 ImGui ID，验证 why.md#需求-ui-文案汉化-场景-配置窗口与列表

## 2. 日志文案替换
- [√] 2.1 在 `ReMakePlacePlugin/ReMakePlacePlugin.cs` 中替换聊天提示与错误信息为中文，验证 why.md#需求-聊天日志汉化-场景-执行保存加载染色
- [√] 2.2 在 `ReMakePlacePlugin/SaveLayoutManager.cs` 中替换导出完成提示为中文，验证 why.md#需求-聊天日志汉化-场景-执行保存加载染色
- [√] 2.3 在 `ReMakePlacePlugin/Memory.cs` 中替换模式错误提示为中文，验证 why.md#需求-聊天日志汉化-场景-执行保存加载染色

## 3. 安全检查
- [√] 3.1 执行安全检查（按G9: 输入验证、敏感信息处理、权限控制、EHRB风险规避）

## 4. 文档更新
- [√] 4.1 更新 `helloagents/wiki/modules/gui.md` 记录 UI 汉化要求
- [√] 4.2 更新 `helloagents/wiki/modules/core.md` 记录聊天提示汉化
- [√] 4.3 更新 `helloagents/wiki/modules/layout.md` 记录导出提示汉化
- [√] 4.4 更新 `helloagents/wiki/modules/memory.md` 记录错误提示汉化
- [√] 4.5 更新 `helloagents/CHANGELOG.md` 记录本次变更

## 5. 测试
- [-] 5.1 手动打开配置窗口，覆盖保存/加载/染色/错误提示流程，检查中文显示与布局
> 备注: 未具备游戏内运行环境，无法执行手动验证
