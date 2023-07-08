
# Compressed Image Format

A simple image format for storing compressed layered images.


## Authors

- [@CodeCraftingMC](https://github.com/CodeCraftingMC/)


## License

[MIT](https://choosealicense.com/licenses/mit/)


## Features

- Simple to use
- Cross platform Library
- Compression
- Layers
## FAQ
---
## Usage/Examples

### Create Image

```csharp
CompressedImage newImage = new(800, 600, Color.Black);
CompressedImage imageFromBytes = new(File.ReadAllBytes("path/to/image.cif"));
```

### Save Image

```csharp
File.WriteAllBytes("path/to/image.cif", newImage.Compress());
```

### Set Pixels

```csharp
newImage.Layers[0].SetPixel(400, 300, Color.White);
```

### Add Layers

```csharp
newImage.Layers.Add(new(800, 600, Color.Gray) { Transparency = 127 });
```
