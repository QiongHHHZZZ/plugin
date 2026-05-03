# 技术设计: UI 文案硬编码汉化

## 技术方案
### 核心技术
- C# 字符串直接替换（不引入 i18n）

### 实现要点
- 在 `ReMakePlacePlugin/Gui/ConfigurationWindow.cs` 替换所有用户可见字符串
- 在 `ReMakePlacePlugin/ReMakePlacePlugin.cs`、`ReMakePlacePlugin/SaveLayoutManager.cs`、`ReMakePlacePlugin/Memory.cs` 替换聊天提示与错误文本
- ImGui 相关标签保留 `###` / `##` 后缀 ID
- 保留游戏内数据名称（物品名、染料名等）不做翻译

## 安全与性能
- 安全: 不涉及权限或数据变更
- 性能: 文案替换无性能影响

## 测试与部署
- 测试: 游戏内手动打开配置窗口，覆盖保存/加载/染色/错误提示流程
- 部署: 常规构建与插件热重载
