extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_InputLegacy();
	RegisterModule_InputLegacy();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_RuntimeInitializeOnLoadManagerInitializer();
	RegisterModule_RuntimeInitializeOnLoadManagerInitializer();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_TextCoreFontEngine();
	RegisterModule_TextCoreFontEngine();

	void RegisterModule_TextCoreTextEngine();
	RegisterModule_TextCoreTextEngine();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UIElementsNative();
	RegisterModule_UIElementsNative();

	void RegisterModule_UIElements();
	RegisterModule_UIElements();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

class Animator; template <> void RegisterUnityClass<Animator>(const char*);
class AnimatorController; template <> void RegisterUnityClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class Avatar; template <> void RegisterUnityClass<Avatar>(const char*);
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
class Flare; template <> void RegisterUnityClass<Flare>(const char*);
class FlareLayer; template <> void RegisterUnityClass<FlareLayer>(const char*);
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class LensFlare; template <> void RegisterUnityClass<LensFlare>(const char*);
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class Light; template <> void RegisterUnityClass<Light>(const char*);
class LightingSettings; template <> void RegisterUnityClass<LightingSettings>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class LightProbes; template <> void RegisterUnityClass<LightProbes>(const char*);
class LineRenderer; template <> void RegisterUnityClass<LineRenderer>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class Material; template <> void RegisterUnityClass<Material>(const char*);
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class Object; template <> void RegisterUnityClass<Object>(const char*);
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderNameRegistry; template <> void RegisterUnityClass<ShaderNameRegistry>(const char*);
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
class Collider; template <> void RegisterUnityClass<Collider>(const char*);
class MeshCollider; template <> void RegisterUnityClass<MeshCollider>(const char*);
class PhysicsManager; template <> void RegisterUnityClass<PhysicsManager>(const char*);
class Rigidbody; template <> void RegisterUnityClass<Rigidbody>(const char*);
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
namespace TextRenderingPrivate { class TextMesh; } template <> void RegisterUnityClass<TextRenderingPrivate::TextMesh>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 76 non stripped classes
	//0. Animator
	RegisterUnityClass<Animator>("Animation");
	//1. AnimatorController
	RegisterUnityClass<AnimatorController>("Animation");
	//2. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//3. Avatar
	RegisterUnityClass<Avatar>("Animation");
	//4. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//5. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//6. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//7. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//8. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//9. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//10. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//11. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//12. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//13. Camera
	RegisterUnityClass<Camera>("Core");
	//14. Component
	RegisterUnityClass<Unity::Component>("Core");
	//15. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//16. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//17. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//18. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//19. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//20. Flare
	RegisterUnityClass<Flare>("Core");
	//21. FlareLayer
	RegisterUnityClass<FlareLayer>("Core");
	//22. GameManager
	RegisterUnityClass<GameManager>("Core");
	//23. GameObject
	RegisterUnityClass<GameObject>("Core");
	//24. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//25. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//26. InputManager
	RegisterUnityClass<InputManager>("Core");
	//27. LensFlare
	RegisterUnityClass<LensFlare>("Core");
	//28. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//29. Light
	RegisterUnityClass<Light>("Core");
	//30. LightingSettings
	RegisterUnityClass<LightingSettings>("Core");
	//31. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//32. LightProbes
	RegisterUnityClass<LightProbes>("Core");
	//33. LineRenderer
	RegisterUnityClass<LineRenderer>("Core");
	//34. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//35. Material
	RegisterUnityClass<Material>("Core");
	//36. Mesh
	RegisterUnityClass<Mesh>("Core");
	//37. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//38. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//39. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//40. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//41. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//42. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//43. Object
	//Skipping Object
	//44. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//45. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//46. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//47. RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//48. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//49. Renderer
	RegisterUnityClass<Renderer>("Core");
	//50. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//51. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//52. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//53. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//54. Shader
	RegisterUnityClass<Shader>("Core");
	//55. ShaderNameRegistry
	RegisterUnityClass<ShaderNameRegistry>("Core");
	//56. Sprite
	RegisterUnityClass<Sprite>("Core");
	//57. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//58. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//59. TagManager
	RegisterUnityClass<TagManager>("Core");
	//60. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//61. Texture
	RegisterUnityClass<Texture>("Core");
	//62. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//63. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//64. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//65. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//66. Transform
	RegisterUnityClass<Transform>("Core");
	//67. Collider
	RegisterUnityClass<Collider>("Physics");
	//68. MeshCollider
	RegisterUnityClass<MeshCollider>("Physics");
	//69. PhysicsManager
	RegisterUnityClass<PhysicsManager>("Physics");
	//70. Rigidbody
	RegisterUnityClass<Rigidbody>("Physics");
	//71. Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//72. TextMesh
	RegisterUnityClass<TextRenderingPrivate::TextMesh>("TextRendering");
	//73. Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//74. CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//75. CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");

}