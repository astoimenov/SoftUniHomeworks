<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>03. SidebarBuilder</title>
	<style type="text/css">
		aside {
			width: 150px;
		}
		section {
			float: left;
			width: 100%;
			display: inline-block;
			padding: 10px 20px;
			margin: 10px 0;
			border-radius: 10px;
			background-color: #aef;
		}
	</style>
</head>
<body>
	<form method="post">
		<label for="cats">Categories: </label>
		<input type="text" name="cats"><br>
		<label for="tags">Tags: </label>
		<input type="text" name="tags"><br>
		<label for="months">Months: </label>
		<input type="text" name="months"><br>
		<input type="submit" value="Generate" name="submit">
	</form>
	<?php if( isset( $_POST['submit'] ) ) : ?>
	<aside>
		<section id="cats">
			<h3>Categories</h3>
			<ul>
			<?php
			$cats = explode( ', ', $_POST['cats'] );
			foreach ($cats as $category) : ?>
				<li>
					<a href="#">
						<?php echo $category; ?>
					</a>
				</li>
			<?php endforeach; ?>
			</ul>
		</section>
		<section id="tags">
			<h3>Tags</h3>
			<ul>
			<?php
			$tags = explode( ', ', $_POST['tags'] );
			foreach ($tags as $tag) : ?>
				<li>
					<a href="#">
						<?php echo $tag; ?>
					</a>
				</li>
			<?php endforeach; ?>
			</ul>
		</section>
		<section id="months">
			<h3>Months</h3><ul>
			<?php
			$months = explode( ', ', $_POST['months'] );
			foreach ($months as $month) : ?>
				<li>
					<a href="#">
						<?php echo $month; ?>
					</a>
				</li>
			<?php endforeach; ?>
			</ul>
		</section>
	</aside>
	<?php endif; ?>
</body>
</html>
