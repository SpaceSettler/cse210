
public class Video
{
	private string _title;
	private string _author;
	private int _length;
	private List<Comment> _comments = new List<Comment>();

	public Video(string title, string author, int length)
	{
		_title = title;
		_author = author;
		_length = length;
	}

	public void GetComments()
	{
		foreach (Comment com in _comments)
		{
			Console.WriteLine(com.GetComments());
		}
	}
	public void SetComments(Comment comment)
	{
		_comments.Add(comment);
	}
	public string Details()
	{
		return $"Title: {_title} Author: {_author} Length: {_length} Comments: {_comments.Count}";
	}
}