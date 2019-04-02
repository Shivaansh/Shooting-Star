# Shooting-Star

### UnityYAMLMerge

If you're using Git on your Mac to merge branches, add the following to the end of your local .git/config:

```
[merge]
  tool = unityyamlmerge

[mergetool "unityyamlmerge"]
  trustExitCode = false
  cmd = '/Applications/Unity/Unity.app/Contents/Tools/UnityYAMLMerge' merge -p "$BASE" "$REMOTE" "$LOCAL" "$MERGED"
```

To use the tool, do

```
git merge [branch-name]
```

If there's any conflict, do

```
git mergetool
```

Hopefully UnityYAMLMerge will help you resolve the conflicts in .unity files.

If you're not using Git on a Mac, please refer to https://docs.unity3d.com/Manual/SmartMerge.html.
